var attendancefix = attendancefix === undefined ? {
    rootPath: "http://localhost:53338/",
    serverDate: "",
    serverTime: ""
} : attendancefix;

(function () {

    var root = this;

    require.config({
        baseUrl: attendancefix.rootPath + "Scripts/App",
        urlArgs: "bust=" + (+new Date),
        waitSeconds: 200
    });

    function defineThirdPartyModules() {
        // These are already loaded via bundles.
        // We define them and put them in the root object.
        define("jquery", [], function () { return root.jQuery; });
        define("ko", [], function () { return root.ko; });
        define("amplify", [], function () { return root.amplify; });
        define("select2", [], function () { return root.select2; });
    }

    defineThirdPartyModules();

})();

$(document).ready(function () {

    require(["AttendanceFix/attendancefix.view"]);

});