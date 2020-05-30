function contar() {
    var txtInicio = document.getElementById('txtInicio');
    var txtFim    = document.getElementById('txtFim');
    var txtPasso  = document.getElementById('txtPasso');
    var txtResul  = document.querySelector('div#res');

    if (txtInicio.value.length == 0 || txtFim.value.length == 0 || txtPasso.value.length == 0) {
        txtResul.innerHTML = 'Impossível contar!';
        window.alert(' [ERRO] Faltam dados! ');

    } else {
        txtResul.innerHTML = 'Contando: <br/>';
        var i = Number(txtInicio.value);
        var f = Number(txtFim.value);
        var p = Number(txtPasso.value);
        if(p <= 0){
            window.alert('Passo inválido! CONSIDERANDO passo igual a 1');
            p = 1;
        }
        //Contagem crescente
        if(i < f) {
            for(i; i <= f; i += p) {
                txtResul.innerHTML += ` ${i} \u{1F449}`;
            }
        } else {
           //Contagem regressiva
            for(i; i >= f; i -= p) {
                txtResul.innerHTML += `${i} \u{1F449}`;
            }
        }
        txtResul.innerHTML += `\u{1F3C1}`;
    }
}