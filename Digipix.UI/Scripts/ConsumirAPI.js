
function get(url, callBack) {
    $.ajax(
        {
            type: 'GET',
            url: url,
            dataType: 'json',
            crossDomain: true,
            async: true,
            success: function (data) {
                callBack(data);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert("jqXHR: " + jqXHR + ", textStatus: " + textStatus + ", errorThrown: " + errorThrown);
            }
        });
}
