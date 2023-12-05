//coloca máscara nos campos do formulário de pedido e produto.
$(document).ready(function () {
    $('#telefone').inputmask('(99) 9 9999-9999');
    $('#cep').inputmask('99999-999');
    $('#PedidoEnviado').inputmask('99/99/9999 99:99');
    $('#PedidoEntregueEm').inputmask('99/99/9999 99:99');
    $('#precoProduto').inputmask('99,99');
});