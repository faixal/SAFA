define("AttendanceFix/attendancefix.staffattendance.model",
["ko"], function (ko) {
    var staffAttendanceModel = function() {
        var
            staffAttendanceId = ko.observable(),
            teacherId = ko.observable(),
            attendanceDate = ko.observable(attendancefix.serverDate),
            checkinDate = ko.observable(attendancefix.serverDate),
            checkinTime = ko.observable(attendancefix.serverTime),
            checkoutDate = ko.observable(attendancefix.serverDate),
            checkoutTime = ko.observable(attendancefix.serverTime),
            attendanceStatusId = ko.observable(),
            reasonId = ko.observable(),
            campusId = ko.observable();
            return {
                staffAttendanceId: staffAttendanceId,
                teacherId: teacherId,
                attendanceDate: attendanceDate,
                checkinDate: checkinDate,
                checkinTime: checkinTime,
                checkoutDate: checkoutDate,
                checkoutTime: checkoutTime,
                attendanceStatusId: attendanceStatusId,
                reasonId: reasonId,
                campusId: campusId
            }
        },
        staffAttendanceCtsMapper = function(source) {
            var server = {};

            server.StaffAttendanceId = source.staffAttendanceId();
            server.TeacherId = source.teacherId();
            server.AttendanceDate = source.attendanceDate();

            server.CheckinDate = source.checkinDate();
            server.CheckinTime = source.checkinTime();

            server.CheckoutDate = source.checkoutDate();
            server.CheckoutTime = source.checkoutTime();

            server.AttendanceStatusId = source.attendanceStatusId();
            server.ReasonId = source.reasonId();
            server.CampusId = source.campusId();

            return server;
        },
        staffAttendanceStcMapper = function(source) {
            var client = new staffAttendanceModel();
            client.staffAttendanceId(source.StaffAttendanceId);
            client.teacherId(source.TeacherId);
            client.attendanceDate(source.RecCreatedDtString);

            client.checkinDate(source.CheckInDate);
            client.checkinTime(source.CheckInTime);

            client.checkoutDate(source.CheckOutDate);
            client.checkoutTime(source.CheckOutTime);

            client.attendanceStatusId(source.AttendanceStatusId);
            client.reasonId(source.ReasonId);
            client.campusId(source.CampusId);
            return client;
        };
    return {
        StaffAttendanceModel: staffAttendanceModel,
        StaffAttendanceCtsMapper: staffAttendanceCtsMapper,
        StaffAttendanceStcMapper: staffAttendanceStcMapper
    };
});