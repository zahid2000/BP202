//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

////Disable the send button until connection is established.
//document.getElementById("sendButton").disabled = true;

//connection.on("ReceiveMessage", function (user, message) {
//    var li = document.createElement("li");
//    document.getElementById("messagesList").appendChild(li);
//    // We can assign user-supplied strings to an element's textContent because it
//    // is not interpreted as markup. If you're assigning in any other way, you
//    // should be aware of possible script injection concerns.
//    li.textContent = `${user} says ${message}`;
//});

//connection.start().then(function () {
//    document.getElementById("sendButton").disabled = false;
//}).catch(function (err) {
//    return console.error(err.toString());
//});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value;
//    var message = document.getElementById("messageInput").value;
//    connection.invoke("SendMessageAsync", user, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();


connection.on("GroupMessage", function (user, message) {
    let li = ` <li class="list-group-item">
     <b>${user}</b>
     <p>${message}</p>
 </li>`
    messageList.innerHTML += li
});


connection.start().then(function () {
    let user = JSON.parse(localStorage.getItem("user"))
    if (user) {
        
        joinRow.classList.add("d-none")
        messageRow.classList.remove("d-none")
        connection.invoke("AddGroupAsync", user.group)

    }  
}).catch(function (err) {
    return console.error(err.toString());
});
console.log(connection)
let enterGroupForm = document.getElementById("enterGroupForm");
let userName = document.getElementById("userName");
let group = document.getElementById("group");
let messageForm = document.getElementById("messageForm");
let message = document.getElementById("message")
let joinRow = document.getElementById("joinRow")
let messageRow = document.getElementById("messageRow")
let leaveBtn = document.getElementById("leaveBtn")
let messageList = document.getElementById("messageList")






enterGroupForm.addEventListener("submit", (ev) => {
    ev.preventDefault()

    let user = {
        userName: userName.value,
        group: group.value
    }
    console.log(user)
    localStorage.setItem("user", JSON.stringify(user))
    connection.invoke("AddGroupAsync", user.group)

    joinRow.classList.add("d-none")
    messageRow.classList.remove("d-none")
})


leaveBtn.addEventListener("click", () => {
    let user = JSON.parse(localStorage.getItem("user"))
    connection.invoke("RemoveGroupAsync", user.group)
    localStorage.removeItem("user")
    message.value = "";
    userName.value = ""
    messageList.innerHTML=""
    messageRow.classList.add("d-none")
    joinRow.classList.remove("d-none")
})

messageForm.addEventListener("submit", (ev) => {
    ev.preventDefault();
    let user = JSON.parse(localStorage.getItem("user"))
    connection.invoke("SendGroupMessageAsync", user.userName, user.group, message.value).catch(function (err) {
        return console.error(err.toString());
    });
})