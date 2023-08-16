const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .build();

connection.start().catch(err => console.error(err));

connection.on("ReceiveMessage", (user, message) => {
    const messagesList = document.getElementById("messagesList");
    const messageItem = document.createElement("li");
    messageItem.classList.add("list-group-item");
    messageItem.textContent = `${user}: ${message}`;
    messagesList.appendChild(messageItem);
});
