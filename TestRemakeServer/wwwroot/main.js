var connection = new signalR.HubConnectionBuilder().withUrl("/clock").build();

connection.start().catch(function (err) {
    return console.error(err.toString());
});

setTimeout(function() {
    connection.invoke("GetAllProfiles").catch(err => console.error(err.toString()));
}, 2000);

connection.on("Response", (str) => {
    console.log(str);
});