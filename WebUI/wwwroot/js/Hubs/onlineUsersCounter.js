"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/onlineUsersCounterHub").build();

connection.on("UpdateCount", function (count) {
    $('#UsersOnline').text(count);
});

connection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    //return console.error(err.toString());
});