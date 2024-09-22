// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function GetAllUsers() {
    $.ajax({
        url: "/Home/GetAllUsers",
        method: "GET",
        success: function (data) {
            console.log(data);
            let content = "";
            for (var i = 0; i < data.length; i++) {
                let style = '';
                let subContent = '';
                if (data[i].hasRequestPending) {
                    subContent = `<button class='btn btn-outline-secondary' >Already Sent</button>`
                }
                else {
                    if (data[i].isFriend) {
                        subContent = `<button class='btn btn-outline-secondary' >UnFollow</button>`
                    }
                    else {
                        subContent = `<button onclick="SendFollow('${data[i].id}')" class='btn btn-outline-primary' >Follow</button>`
                    }
                }
                if (data[i].isOnline) {
                    style = 'border:5px solid springgreen';
                }
                else {
                    style = 'border:5px solid red';
                }
                const item = `
                <div class='card' style='${style};width:220px;margin:5px'>
                <img style='width:100%;height:220px;' src='/images/${data[i].image}' />
                <div class='card-body'>
                    <h5 class='card-title'>${data[i].userName}</h5>
                    <p class='card-text'> ${data[i].email} </p>
                    ${subContent}
                </div>
                </div>
                `;
                content += item;
            }
            $("#allUsers").html(content);
        }

    })
}

GetAllUsers();


function SendFollow(id) {
    const element = document.querySelector("#alert");
    element.style.display = "none";
    $.ajax({
        url: `/Home/SendFollow/${id}`,
        method: "GET",
        success: function (data) {
            element.style.display = "block";
            element.innerHTML = "Your friend request sent successfully";
            setTimeout(() => {
                element.innerHTML = "";
                element.style.display = "none";
            }, 5000);
        }
    })
}