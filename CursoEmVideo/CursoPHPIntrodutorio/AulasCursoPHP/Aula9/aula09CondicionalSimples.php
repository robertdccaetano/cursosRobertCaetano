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

        if($i >= 18){
            $v = "já pode votar";
            $d = "já pode dirigir";
        }
        else {
            $v = "não pode votar";
            $d = "não pode dirigir";
        }
        echo "<br/>Com essa idade você $v e também $d";
        
    ?>


</body>
</html>