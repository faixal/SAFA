/*
    View for the Cut IT  page
*/
define("AttendanceFix/attendancefix.view",
["jquery", "AttendanceFix/attendancefix.viewmodel"], function ($) {
    // View 
    attendancefix.staff.view = (function (specifiedViewModel) {
        var // View model 
            viewModel = specifiedViewModel,
            // Binding root used with knockout
            bindingRoot = $("#attendance-fix-body-section")[0];
        return {
            bindingRoot: bindingRoot,
            viewModel: viewModel
        };
    })(attendancefix.staff.viewModel);

    // Initialize the view model
    attendancefix.staff.viewModel.initialize(attendancefix.staff.view);
});