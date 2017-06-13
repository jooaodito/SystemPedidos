$(document).ready(function () {
    $(".btnAdd").click(function () {
        $("#Item").val($(this).data("codigo"));
        $("#TotalPedido").val($(this).data("total"));
    })
})
function SalvarPedido() {

    //pegar o item do campo Data
    var data = $("#DataPedido").val();

    //pegar o item do campo Cliente
    var cliente = $("#Cliente").val();

    //Salvar item campo item
    var item = $("#Item").val();

    //pegar o item do campo Valor
    var valor = $("#TotalPedido").val();

    var token = $('input[name="__RequestVerificationToken"]').val();
    var tokenadr = $('form[action="/Pedidoes/Create"] input[name="__RequestVerificationToken"]').val();
    var headers = {};
    var headersadr = {};
    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    //Gravar
    var url = "/Pedidoes/Create";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headersadr
        , data: { IdPedido: 0, DataPedido: data, ClienteId: cliente, ItemId: item, TotalPedido: valor, __RequestVerificationToken: token }
        , success: function (data) {
            if (data == "SUCESSO") {
                location.href = "/Pedidoes/Index";
            }
        }
    });
}
