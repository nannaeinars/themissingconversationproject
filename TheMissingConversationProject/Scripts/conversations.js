function submitConversation() {
    var data = '{pPerson1:\'' + $('#FirstName')[0].value + '\',pPerson2:\'' + $('#SecondName')[0].value + '\'}';
    $.ajax({
        type: "POST",
        url: '/Home/AddConversation',
        data: data,
        contentType: 'application/json',
        dataType: 'json',
        success: function (result) {
            //addAlert(result);

            if (result.status == "success") {
                $('#FirstName').val('');
                $('#SecondName').val('');
            }
        }
    });
}