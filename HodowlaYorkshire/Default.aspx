<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HodowlaYorkshire._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="carousel slide" id="myCarousel" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slite-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="item-active">
                <img src="~/Images/York/Primary.jpg" alt="Nasza duma" runat="server"/>
            </div>
            <div class="item">
                <img src="~/Images/Chihuahua/Primary.jpg" alt="Nasza druga duma" runat="server"/>
            </div>
            <div class="item">
                <img src ="~/Images/Owner.jpg" alt="Nasza właścicielka" />
            </div>
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
    <div class="container">
        <div class="jumbotron">
            <h1>Następny miot za 3 miesiące !</h1>
            <p>Maja nadejść na świat kolejne Pieski. Można już rezerwować. <a href="Contact.aspx" style="color:blue">Skontaktuj się z nami!</a></p>
        </div>
    </div>

    <div class="media">
        <div class="media-left">
            <img src="~/images/Owner.jpg" class="media-object" style="width:80px; height:80px" runat="server"/>
        </div>
        <div class="media-body">
            <h4 class="media-heading">Bogusława Woelk</h4>
            <p>Następny miot za 3 miesiące ! Maja nadejść na świat kolejne Pieski. Można już rezerwować. <a href="Contact.aspx" style="color:blue">Skontaktuj się z nami!</a></p>
        </div>
    </div>
    
</asp:Content>
