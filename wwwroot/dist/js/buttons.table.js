$(document).ready(function(){
    $(".btnChangeStatus").on("click", function(){
        $.ajax({
            type: "POST",
            url: "/API/ChangeStatus/" + $(this).data("idorder"),
            success: function (response) {
                if (response) {
                    location.reload()
                }
            },
            failure: function (response) {
                alert(response.d);
            }
        });
    })

    $(".btnDelete").on("click", function(){
        $.ajax({
            type: "POST",
            url: "/API/DeleteOrder/" + $(this).data("idorder"),
            success: function (response) {
                if (response) {
                    location.reload()
                }
            },
            failure: function (response) {
                alert(response.d);
            }
        });
    })
})