<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercicio05.aspx.cs" Inherits="Gateware.Exercicio05" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Exercício 05</h1>
        <p class="lead">
            <br />5 - Preciso do comando SQL que me traga a soma dos salários recebidos por colaborador e estado no ano de 2014 das tabelas SALARIOS / COLABORADORES / LOCAL_DE_TRABALHO: SALARIOS = Campos (ID_SALARIO, ID_COLABORADOR, VALOR_PAGO, DATA_PAGAMENTO) COLABORADORES = Campos (ID_COLABORADOR, NOME_COLABORADOR, SEXO, IDADE, ESTADO_CIVIL) LOCAL_DE_TRABALHO = Campos (ID_LOCAL, ID_COLABORADOR, NOME_LOCAL, CIDADE, UF)
        </p>                
    </div>
    <asp:UpdatePanel runat="server" ID="upnExercicio01" UpdateMode="Conditional" >
        <ContentTemplate>            
            <div class="col-md-12">                
                <asp:Label runat="server" ID="lblSolucao"></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

