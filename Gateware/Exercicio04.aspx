<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio04.aspx.cs" Inherits="Gateware.Exercicio04" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Exercício 04</h1>
        <p class="lead">
            <br />4 - Com Javascript e/ou Jquery, ao clicar em um botão, popule uma caixa de seleção através de uma requisição Ajax a um arquivo JSON.
        </p>                
    </div>
    <div>
        <a ID="btnExecutar" class="btnExecutar btn btn-primary">Executar</a>
    </div>
    <div>
        <br />
        <br />
    </div>    
    <div class="col-md-12">
        Solução
        <select ID="ddlEstado" class="form-control ddlEstado"></select>
    </div>
    

    <script src="Scripts/Exercicio04.js"></script>
</asp:Content>


