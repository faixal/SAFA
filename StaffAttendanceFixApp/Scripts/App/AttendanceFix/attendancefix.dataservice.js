define("AttendanceFix/attendancefix.dataservice", function () {

    amplify.request.define("getCampuses", "ajax", {
        url: attendancefix.rootPath + "api/CampusApi",
        datatype: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataMap: JSON.stringify,
        decoder: "appEnvelope"
    });
    amplify.request.define("getTeachersByCampus", "ajax", {
        url: attendancefix.rootPath + "api/TeachersApi",
        datatype: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",        
        decoder: "appEnvelope"
    });
    amplify.request.define("getTeacherAttendanceData", "ajax", {
        url: attendancefix.rootPath + "api/StaffAttendanceApi",
        datatype: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",        
        decoder: "appEnvelope"
    });
    amplify.request.define("deleteAttendanceRecord", "ajax", {
        url: attendancefix.rootPath + "api/StaffAttendanceApi",
        datatype: "json",
        type: "DELETE",
        contentType: "application/json; charset=utf-8",
        dataMap: JSON.stringify,
        decoder: "appEnvelope"
    });        
    amplify.request.define("getAttendanceStatuses", "ajax", {
        url: attendancefix.rootPath + "api/AttendanceStatusApi",
        datatype: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",        
        decoder: "appEnvelope"
    });
    amplify.request.define("getStatusReasons", "ajax", {
        url: attendancefix.rootPath + "api/StatusReasonApi",
        datatype: "json",
        type: "GET",
        contentType: "application/json; charset=utf-8",
        decoder: "appEnvelope"
    });
    amplify.request.define("saveAttendanceRecord", "ajax", {
        url: attendancefix.rootPath + "api/StaffAttendanceApi",
        datatype: "json",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataMap: JSON.stringify,
        decoder: "appEnvelope"
    });
    amplify.request.decoders.appEnvelope =
        function (data, status, xhr, success, error) {
            if (data !== null) {
                if (status === "error") {
                    error(xhr.statusText);
                } else if (status === "success") {
                    success(data);
                }
            } else {
                error(xhr.responseText);
            }
        };
    // Define the data service methods
    var dataService = {
        getCampuses: function (callbacks) {
            return amplify.request({
                resourceId: "getCampuses",                
                success: callbacks.success,
                error: callbacks.error
            });
        },
        getTeachersByCampus: function (paramData, callbacks) {
            return amplify.request({
                resourceId: "getTeachersByCampus",
                data: paramData,
                success: callbacks.success,
                error: callbacks.error
            });
        },
        getTeacherAttendanceData: function (paramData, callbacks) {
            return amplify.request({
                resourceId: "getTeacherAttendanceData",
                data: paramData,
                success: callbacks.success,
                error: callbacks.error
            });
        },
        deleteAttendanceRecord: function (paramData, callbacks) {
            return amplify.request({
                resourceId: "deleteAttendanceRecord",
                data: paramData,
                success: callbacks.success,
                error: callbacks.error
            });
        },
        getAttendanceStatuses: function (callbacks) {
            return amplify.request({
                resourceId: "getAttendanceStatuses",
                success: callbacks.success,
                error: callbacks.error
            });
        },
        getStatusReasons: function (callbacks) {
            return amplify.request({
                resourceId: "getStatusReasons",
                success: callbacks.success,
                error: callbacks.error
            });
        },
        saveAttendanceRecord: function (paramData, callbacks) {
            return amplify.request({
                resourceId: "saveAttendanceRecord",
                data: paramData,
                success: callbacks.success,
                error: callbacks.error
            });
        },
    };
    return dataService;
});