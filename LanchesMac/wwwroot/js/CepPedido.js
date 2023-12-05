
//busca cidade e estado por cep
$('#cep').change(function () {
    var cep = $(this).val();
    if (cep.length > 0) {
        // Chamada AJAX para buscar o CEP
        axios
            .get('https://api.postmon.com.br/v1/cep/' + cep)
            .then(function (response) {
                var endereco = response.data;
                // Preencher os campos com os dados retornados
                $('#nomeEstado').val(endereco.estado);
                $('#cidade').val(endereco.cidade);
            })
            .catch(function (error) {
                console.log(error);
                showCEPNotFoundMessage();
                $('#cep').val('');
            });
    }
});

//dispara a mensagem "CEP Não encontrado"
function showCEPNotFoundMessage() {
    var overlay = $('<div>').addClass('overlay');
    var messageBox = $('<div>').addClass('cepNotFound');
    var messageText = $('<span>').text('CEP não encontrado!').css('color', 'red');

    messageBox.append(messageText);
    $('body').append(overlay).append(messageBox);
    overlay.fadeIn();
    messageBox.fadeIn();

    setTimeout(function () {
        hideCEPNotFoundMessage();
    }, 1000);
}

function hideCEPNotFoundMessage() {
    $('.overlay').fadeOut(function () {
        $(this).remove();
    });
    $('.cepNotFound').fadeOut(function () {
        $(this).remove();
    });
}
