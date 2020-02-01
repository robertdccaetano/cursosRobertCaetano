function carregar() {

    var img = window.document.getElementById('imagem');
    var msg = window.document.getElementById('msg');

    var data = new Date();
    var hora = 20  //data.getHours();

    msg.innerHTML = `Agora são ${hora} horas.`;
    if(hora >= 0 && hora < 12) {
        img.src = 'manha.png';
        document.body.style.background = '#e2cd9f';
        //BOM DIA
    } else if (hora >= 12 && hora <= 18) {
        img.src = 'tarde.png';
        document.body.style.background = '#b9846f';
        //BOA TARDE
    } else {
        img.src =  'noite.png';
        document.body.style.background = '#515154';
        //BOA NOITE
    }
}

