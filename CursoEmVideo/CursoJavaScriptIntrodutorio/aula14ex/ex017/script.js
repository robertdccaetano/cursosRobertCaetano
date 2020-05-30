function calcular() {
    var valor = document.getElementById('txtTabuada');
    var res = document.querySelector('select#tabRes');

    if ( valor.value.length == 0) {
        window.alert(' Por favor digite um número!');

    } else {

        var i = Number(valor.value);
        var cont  = 1;
        res.innerHTML = '';

        for(cont; cont <= 10; cont++) {
            let item = document.createElement('option');
            item.text = `${i} x ${cont} = ${i*cont}`;
            item.value = `tab${cont}`;
            res.appendChild(item);
            
        }
    }
}