define("AttendanceFix/attendancefix.viewmodel",
["jquery", "ko", "AttendanceFix/attendancefix.dataservice", "AttendanceFix/attendancefix.staffattendance.model"], function ($, ko, dataservice, saModel) {
    attendancefix.staff = {
        viewModel: (function() {
            var
                view,
                allCampuses = ko.observableArray([]),
                allTeachers = ko.observableArray([]),
                selectedCampus = ko.observable(),
                selectedTeacher = ko.observable(),
                startDate = ko.observable(attendancefix.serverDate),
                endDate = ko.observable(attendancefix.serverDate),
                teacherAttendanceRecords = ko.observableArray([]),
                attendanceStatuses = ko.observableArray([]),
                statusReasons = ko.observableArray([]),
                isLoading = ko.observable(false),
                editingStaffAttedanceId = ko.observable(0),
                activeRecord = ko.observable(new saModel.StaffAttendanceModel()),
                showProgress = function () {$("#overlay").show();},
                hideProgress = function () { $("#overlay").hide(); },
                showModal = function () {$("#myModal").show();},
                hideModal = function () {$("#myModal").hide();},
                getCampuses = function() {
                    dataservice.getCampuses({
                        success: function (data) {                            
                            allCampuses(data);
                        },
                        error: function(response) {
                            toastr.error("Failed to load campuses. Error: " + response);
                        }
                    });
                },
                getTeachersByCampus = function () {
                    var server = { campusId: selectedCampus() };                    
                    dataservice.getTeachersByCampus(server, {
                        success: function (data) {
                            allTeachers(data);
                            $(".teachers").select2();
                        },
                        error: function (response) {
                            toastr.error("Failed to load teachers by campus. Error: " + response);
                        }
                    });
                },
                getAttendanceStatuses = function () {
                    dataservice.getAttendanceStatuses({
                        success: function (data) {
                            attendanceStatuses(data);
                        },
                        error: function (response) {
                            toastr.error("Failed to load attendance statuses. Error: " + response);
                        }
                    });
                },
                getStatusReasons = function () {
                    dataservice.getStatusReasons({
                        success: function (data) {
                            statusReasons(data);
                        },
                        error: function (response) {
                            toastr.error("Failed to load status reasons. Error: " + response);
                        }
                    });
                },
                validateDates = function(date1, date2) {
                    var errorMsg = "";
                    if (date1 === null || date1 === undefined || date1 === "") {
                        errorMsg = "Date1 is empty";
                        return errorMsg;
                    }
                    if (date2 === null || date2 === undefined || date2 === "") {
                        errorMsg = "Date2 is empty";
                        return errorMsg;
                    }
                    var d1 = Date.parse(date1);
                    var d2 = Date.parse(date2);
                    if (d2 < d1) {
                        errorMsg = "Date2 is previous than Date1";
                    }
                    return errorMsg;
                },
                //------------Load attendance records in table---------------//
                getTeacherAttendanceData = function () {
                    if (selectedCampus() === undefined) { toastr.error("Select a campus to get staff attendance data."); return; }
                    var dValMsg = validateDates(startDate(), endDate());
                    if (dValMsg !== "") { toastr.error(dValMsg); return; }

                    var teacId = selectedTeacher() === undefined ? 0 : selectedTeacher();
                    showProgress();
                    isLoading(true);
                    var server = { teacherId: teacId, campusId: selectedCampus(), startDate: startDate(), endDate: endDate() };
                    
                    dataservice.getTeacherAttendanceData(server, {
                        success: function (data) {
                            isLoading(false);
                            teacherAttendanceRecords(data);
                            hideProgress();
                        },
                        error: function (response) {
                            isLoading(false);
                            toastr.error("Failed to load staff attendance records. Error: " + response);
                            hideProgress();
                        }
                    });
                },
                //------------Delete attendance records --------------------//
                deleteAttendanceRecord= function(obj) {
                    if (confirm("Are you sure you want to delete this record?")) {
                        showProgress();
                        var server = obj;
                        dataservice.deleteAttendanceRecord(server, {
                            success: function (data) {
                                if (data === true) {
                                    toastr.success("Attendance record deleted successfully.");
                                    getTeacherAttendanceData();
                                } else {
                                    toastr.error("Something bad happened while deleting attendance record.");
                                }
                                hideProgress();
                            },
                            error: function (response) {                                
                                toastr.error("Failed to delete staff attendance records. Error: " + response);
                                hideProgress();
                            }
                        });
                    }
                },                               
                editAttendanceRecord = function(obj) {
                    var client = saModel.StaffAttendanceStcMapper(obj);
                    activeRecord(client);
                    selectedTeacher(obj.TeacherId);
                    editingStaffAttedanceId(obj.StaffAttendanceId);
                },
                cancelEditRecord = function() {
                    editingStaffAttedanceId(0);
                },
                addNewAttendanceRecord = function () {
                    activeRecord(new saModel.StaffAttendanceModel());                    
                    showModal();
                    $(".teachers").select2();
                },
                validateRequestObject = function() {
                    var errorMsg = "";
                    var obj = activeRecord();
                    if (obj.campusId() === undefined) {
                        errorMsg = "Please select campus."; return errorMsg;
                    }
                    if (obj.teacherId() === undefined) {
                        errorMsg = "Please select teacher."; return errorMsg;
                    }
                    if (obj.attendanceDate() === "") {
                        errorMsg = "Please select attendance date."; return errorMsg;
                    }
                    
                    if (obj.attendanceStatusId() === undefined) {

                        if (obj.checkinDate() === "") { errorMsg = "Checkin date is invalid."; return errorMsg; }
                        if (obj.checkinTime() === "") { errorMsg = "Checkin time is invalid."; return errorMsg; }

                        //if (obj.staffAttendanceId() === undefined) {
                        //    if (obj.checkoutDate() === "") { errorMsg = "Checkout date is invalid."; return errorMsg; }
                        //    if (obj.checkoutTime() === "") { errorMsg = "Checkout time is invalid."; return errorMsg; }
                        //}
                        
                        if (obj.checkoutDate() !== "" && obj.checkoutTime() !== "") {
                            var checkin = new Date(obj.checkinDate() + " " + obj.checkinTime());
                            var checkout = new Date(obj.checkoutDate() + " " + obj.checkoutTime());

                            if (checkin > checkout) {
                                errorMsg = "Checkin date time cannot be smaller than checkout date time.";
                                return errorMsg;
                            }
                        }                        
                    }

                    return errorMsg;
                },
                saveAttendanceRecord = function () {

                    activeRecord().teacherId(selectedTeacher());
                    activeRecord().campusId(selectedCampus());
                    var errMsg = validateRequestObject();
                    if (errMsg !== "") { toastr.error(errMsg); return ; }
                    var server = saModel.StaffAttendanceCtsMapper(activeRecord());
                    showProgress();
                    dataservice.saveAttendanceRecord(server, {
                        success: function (data) {
                            if (data === true) {                                
                                toastr.success("Attendance record added successfully.");
                                getTeacherAttendanceData();
                                selectedTeacher(undefined);
                                activeRecord(new saModel.StaffAttendanceModel());                                
                                cancelEditRecord();
                                $(".teachers").select2();                                          
                            } else {
                                toastr.error("Something bad happened while adding attendance record.");
                            }
                            hideProgress();
                        },
                        error: function (response) {
                            toastr.error("Failed to add staff attendance records. Error: " + response);
                            hideProgress();
                        }
                    });
                },
                adjustReasonId = function() {
                    activeRecord().reasonId(undefined);
                    activeRecord().checkinDate(attendancefix.serverDate);
                    activeRecord().checkoutDate(attendancefix.serverDate);
                    activeRecord().checkinTime(attendancefix.serverTime);
                    activeRecord().checkoutTime(attendancefix.serverTime);
                },
                initialize = function(specifiedView) {
                    view = specifiedView,
                    // Applying KnockoutBindings
                    ko.applyBindings(view.viewModel, view.bindingRoot);
                    getCampuses();
                    getAttendanceStatuses();
                    getStatusReasons();                    
                };
            return {
                initialize: initialize,
                view: view,
                allCampuses: allCampuses,
                selectedCampus: selectedCampus,
                getTeachersByCampus: getTeachersByCampus,
                allTeachers: allTeachers,
                selectedTeacher: selectedTeacher,
                startDate: startDate,
                endDate: endDate,
                getTeacherAttendanceData: getTeacherAttendanceData,
                teacherAttendanceRecords: teacherAttendanceRecords,
                isLoading: isLoading,
                deleteAttendanceRecord: deleteAttendanceRecord,
                activeRecord: activeRecord,
                editAttendanceRecord: editAttendanceRecord,
                attendanceStatuses: attendanceStatuses,
                statusReasons: statusReasons,
                addNewAttendanceRecord: addNewAttendanceRecord,
                saveAttendanceRecord: saveAttendanceRecord,
                editingStaffAttedanceId: editingStaffAttedanceId,
                cancelEditRecord: cancelEditRecord,
                adjustReasonId: adjustReasonId
            };
        })()
    }
});