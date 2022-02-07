function send_mail() {
    var name = jQuery("#name").val();
    var email = jQuery("#email").val();
    var phone = jQuery("#phone").val();
    var subject = jQuery("#subject").val();
    var message = jQuery("#message").val();
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    var flag = 0;
    if (name == "") {
        jQuery("#name").addClass('invalid');
        jQuery("#val_user_name").html("Your Name is Required");
        flag = 1;
    } else {
        jQuery("#name").removeClass('invalid');
        jQuery("#val_user_name").html("");
    }

    if (email == "") {
        jQuery("#email").addClass('invalid');
        jQuery("#val_user_email").html("Please Enter Email");
        flag = 1;
    } else if (!email.match(mailformat)) {
        jQuery("#email").addClass('invalid');
        jQuery("#val_user_email").html("Please Enter Valid Email");
        flag = 1;
    } else {
        jQuery("#email").removeClass('invalid');
        jQuery("#val_user_email").html("");
    }

    if (subject == "") {
        jQuery("#subject").addClass('invalid');
        jQuery("#val_subject").html("Subject is Required");
        flag = 1;
    } else {
        jQuery("#subject").removeClass('invalid');
        jQuery("#val_subject").html("");
    }
    if (message == "") {
        jQuery("#message").addClass('invalid');
        jQuery("#val_message").html("Please Describe your thoughts");
        flag = 1;
    } else {
        jQuery("#message").removeClass('invalid');
        jQuery("#val_message").html("");
    }

    if (flag == 1) {
        return false;
    }

    var data = {
        "Fullname": name,
        "Email": email,
        "Phone": phone,
        "Subject": subject,
        "Message": message,
    };

    jQuery.ajax({
        type: "POST",
        crossOrigin: true,
        url: "https://script.google.com/macros/s/AKfycbxGzgnEKlWLWl68ER4OV-YL1cUT-tlW969qVAB4ndZAPNBN-zHjC2kEzc-69yWFHU_N/exec",
        data: data,
        success: function(response) {
            if (response == '1') {
                jQuery('#err_message').show();
            } else {
                jQuery('#suce_message').show();
            }
            jQuery("#contact-form")[0].reset();
        }
    });

}