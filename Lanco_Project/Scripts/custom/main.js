$(document).ready(function () {
    $(".sidebar-dropdown > a").click(function () {
        $(".sidebar-submenu").slideUp(200);
        if (
            $(this)
                .parent()
                .hasClass("active")
        ) {
            $(".sidebar-dropdown").removeClass("active");
            $(this)
                .parent()
                .removeClass("active");
        } else {
            $(".sidebar-dropdown").removeClass("active");
            $(this)
                .next(".sidebar-submenu")
                .slideDown(200);
            $(this)
                .parent()
                .addClass("active");
        }
    });

    $("#close-sidebar").click(function () {
        $(".page-wrapper").removeClass("toggled");
    });

    $("#show-sidebar").click(function () {
        $(".page-wrapper").addClass("toggled");
    });

    if ($('#alert_message').length) {
        $("#alert_message").fadeTo(11000, 500).slideUp(500, function () {
            $("#alert_message").slideUp(500);

            var pathname = $(location).attr('pathname').split("/");

            $.ajax({
                url: '/' + pathname[1] +'/ClearSession',
                type: 'POST',
                dataType: "json",
                contentType: 'application/json',
                data: null
            });  

        });
    }
});


function clear_inputs(element_id) {
    jQuery("#" + element_id).find(':input').each(function () {
        switch (this.type) {
            case 'password':
            case 'text':
            case 'textarea':
            case 'file':
            case 'select-one':
            case 'select-multiple':
            case 'date':
            case 'number':
            case 'tel':
            case 'email':
                jQuery(this).val('');
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
                break;
        }
    });
}