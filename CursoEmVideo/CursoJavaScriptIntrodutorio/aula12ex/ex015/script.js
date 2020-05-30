function verificar() {
    var data = new Date();
    var ano = data.getFullYear();
    var fAno = document.getElementById('txtano');
    var res = document.querySelector('div#res');
    if(fAno.value.length == 0 || fAno.value > ano) {
        window.alert('[ERRO] Verifique os dados e tente novamente');
    } else {
        var fSex = document.getElementsByName('radsex');
        var idade = ano - Number(fAno.value);
        var genero = '';
        var img = document.createElement('img');
        img.setAttribute('id', 'foto');

        if (fSex[0].checked) {
            genero = 'Homem';
            if (idade >= 0 && idade < 10) {
                //Criança
                img.setAttribute('src', 'bebe-m.png');
            } else if ( idade < 21 ) {
                img.setAttribute('src', 'jovem-m.png');
                //Jovem
            } else if ( idade < 50 ) {
                img.setAttribute('src', 'adulto-m.png');
                //Adulto
            } else {
                img.setAttribute('src', 'idoso-m.png');
                //Idoso
            }

        } else if (fSex[1].checked)  {
            genero = 'Mulher';
            if ( idade >= 0 && idade < 10 )  { 
                //Criança
                img.setAttribute('src', 'bebe-f.png');
            } else if (idade < 21) {
                img.setAttribute('src', 'jovem-f.png');
                //Jovem
            } else if (idade < 50 ) {
                img.setAttribute('src', 'adulto-f.png');
                //Adulto
            } else {
                img.setAttribute('src', 'idoso-f.png');
                //Idoso
            }
        }
        res.style.textAlign = 'center';
        res.innerHTML = `Detectamos ${genero} com ${idade} anos.`;
        res.appendChild(img);
    }
}

