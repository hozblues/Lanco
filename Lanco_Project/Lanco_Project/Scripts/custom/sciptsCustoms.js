$(document).ready(function () {
    if ($('#msg-alert').length) {
        $("#msg-alert").fadeTo(11000, 500).slideUp(500, function () {
            $("#msg-alert").slideUp(500);
        });
    }
});