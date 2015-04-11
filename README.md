# themissingconversationproject

Method to add conversations:
Format of input data: "{pPerson1:'me',pPerson2:'you'}"
Output data: 'status' either "ok" or "error", and a 'messsage' 

Example:
var data = '{pPerson1:\'' + $('#FirstName')[0].value + '\',pPerson2:\'' + $('#SecondName')[0].value + '\'}';
$.ajax({
    type: "POST",
    url: '/Home/AddConversation',
    data: data,
    contentType: 'application/json',
    dataType: 'json',
    success: function (result) {

        if (result.status == "success") {
            $('#FirstName').val('');
            $('#SecondName').val('');
        }
    }
});

Method to get all conversations in db:
Format of output data: 
[Object { ConversationId=1,  FirstPerson="me",  SecondPerson="you",  etc (see data members below)...},
 Object { ConversationId=2,  etc...}, 
 ...]
 
ConversationId: 1
DateAdded: "/Date(1428606435937)/"
FirstPerson: "me"
SecondPerson: "you"

Example:
$.ajax({
    type: 'POST',
    url: '/Home/GetConversations',
    async: false,
    contentType: 'application/json; charset=utf-8',
    dataType: 'json',
    success: function (result) {
        output = result.conv;
    }
});
