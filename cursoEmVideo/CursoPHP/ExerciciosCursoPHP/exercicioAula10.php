<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Estados - Exercício Aula 10</title>

    <style>
        span.foco {
            color: red;

        }
    
    </style>
</head>
<body>
    <?php
        $estado = isset($_GET["estado"])?$_GET["estado"]:"estado invalido";

        switch ($estado) {
            case sul:
                $reg = "Região Sudeste";
                break;
            case sudeste:
                $reg = "Região Sudeste";
                break;
            case norte:
                $reg = "Região Norte";
                break;
            case nordeste:
                $reg = "Região Nordeste";
                break;
            case centro-oeste:
                $reg = "Região Centro Oeste";
                break;
            default:
                $reg = "Região Centro Oeste, mais precisamente Distrito Federal";                
        }

        echo "Você mora na <span class='foco'>$reg!</span>";
    ?>
    <br/><a href="javascript:history.go(-1)">Voltar</a>

</body>
</html>