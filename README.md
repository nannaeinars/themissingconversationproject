# themissingconversationproject

Method to add conversations:<br>
Format of input data: "{pPerson1:'me',pPerson2:'you'}"<br>
Output data: 'status' either "ok" or "error", and a 'messsage'<br>

Example:<br>
var data = '{pPerson1:\'' + $('#FirstName')[0].value + '\',pPerson2:\'' + $('#SecondName')[0].value + '\'}';<br>
$.ajax({<br>
    type: "POST",<br>
    url: '/Home/AddConversation',<br>
    data: data,<br>
    contentType: 'application/json',<br>
    dataType: 'json',<br>
    success: function (result) {<br>
        if (result.status == "success") {<br>
            $('#FirstName').val('');<br>
            $('#SecondName').val('');<br>
        }<br>
    }<br>
});<br>

Method to get all conversations in db:<br>
Format of output data: <br>
[Object { ConversationId=1,  FirstPerson="me",  SecondPerson="you",  etc (see data members below)...},<br>
 Object { ConversationId=2,  etc...}, <br>
 ...]<br>
 
ConversationId: 1<br>
DateAdded: "/Date(1428606435937)/"<br>
FirstPerson: "me"<br>
SecondPerson: "you"<br>

Example:<br>
$.ajax({<br>
    type: 'POST',<br>
    url: '/Home/GetConversations',<br>
    async: false,<br>
    contentType: 'application/json; charset=utf-8',<br>
    dataType: 'json',<br>
    success: function (result) {<br>
        output = result.conv;<br>
    }<br>
});<br>
