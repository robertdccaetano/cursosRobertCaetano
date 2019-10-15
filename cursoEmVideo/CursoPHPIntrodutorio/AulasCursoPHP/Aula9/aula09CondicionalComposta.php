<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula09 - Condicional</title>
</head>
<body>
    <?php
        $a = isset($_GET["ano"])?$_GET["ano"]:1900;
        $i = date("Y") - $a;
        echo "Você nasceu em $a e tem $i anos";

        if($i < 16) {
            $tipoVoto = "nao vota";
        }
        elseif (($i >= 16 && $i < 18) || ($i > 65)) {
                $tipoVoto = "voto opcional";
            }
        else {
                $tipoVoto = "voto obrigatorio";
        }

        echo "<br/>Para essa idade, $tipoVoto";
    ?>
</body>
</html>