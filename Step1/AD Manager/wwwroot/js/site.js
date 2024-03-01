﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Navbar content show and hide.
function showContent(id) {
    // 隱藏所有內容
    var contents = document.getElementsByClassName("content");
    for (var i = 0; i < contents.length; i++) {
        contents[i].classList.remove("active");
    }

    // 顯示指定ID的內容
    var content = document.getElementById(id);
    if (content) {
        content.classList.add("active");
    }
}

// Sidebar content show and hide.
function showSidebarContent(id) {
    // 隱藏所有內容
    var contents = document.getElementsByClassName("sidebar-content");
    for (var i = 0; i < contents.length; i++) {
        contents[i].classList.remove("sidebar-active");
    }

    // 顯示指定ID的內容
    var content = document.getElementById(id);
    if (content) {
        content.classList.add("sidebar-active");
    }
}