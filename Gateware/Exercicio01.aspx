<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio01.aspx.cs" Inherits="Gateware.Exercicio01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Exercício 01</h1>
        <p class="lead">
            <br />1 - Em C#, encontre o maior numero inteiro em um array.
        </p>                
    </div>
    <asp:UpdatePanel runat="server" ID="upnExercicio01" UpdateMode="Conditional" >
        <ContentTemplate>            
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnExecutar01"  CssClass="btn btn-primary" Text="Executar Solução 01" OnClick="btnExecutar01_Click" />
                <asp:Label runat="server" ID="lblSolucao01"></asp:Label>
            </div>
            <div class="col-md-12">
                <br />
                <asp:Button runat="server" ID="btnExecutar02" CssClass="btn btn-primary" Text="Executar Solução 02" OnClick="btnExecutar02_Click" />
                <asp:Label runat="server" ID="lblSolucao02"></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
