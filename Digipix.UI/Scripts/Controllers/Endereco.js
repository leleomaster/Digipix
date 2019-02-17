
var urlEndereco = "http://localhost:57265/api/Endereco/v0/GetByZipCode/";

addEventsEndereco();

function addEventsEndereco() {
    $("#Cep").blur(function () {
        limpaFormularioCep();
        getEndereco(this);
    });
}

function getEndereco(obj) {
    var cep = $(obj).val().replace(/\D/g, '');

    if (cep !== "") {

        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {
            get(urlEndereco + cep, popularCamposEndereco);
        }
        else {
            limpaFormularioCep();
            alert("Formato de CEP inválido.");
        }
    }
    else {
        limpaFormularioCep();
    }
}

function popularCamposEndereco(dados) {
    limpaFormularioCep();

    if (dados === null) {
        alert("Cep inválido");
    } else {
        $("#Logradouro").val(dados.Logradouro);
        $("#Numero").val(dados.Numero);
        $("#Bairro").val(dados.Bairro);
        $("#Cidade").val(dados.Cidade);
        $("#Estado").val(dados.Estado);
        $("#Complemento").val(dados.Complemento);

        $("#Numero").removeAttr("disabled");
        $("#Complemento").removeAttr("disabled");
    }
}

function limpaFormularioCep() {
    $("#Logradouro").val("");
    $("#Numero").val("");
    $("#Bairro").val("");
    $("#Cidade").val("");
    $("#Estado").val("");
    $("#Complemento").val("");
}
