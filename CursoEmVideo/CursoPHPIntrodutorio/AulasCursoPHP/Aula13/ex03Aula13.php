<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <?php
        $c = 0;
        $n = isset($_GET["num"]) ? $_GET["num"]: 1;
        echo "<h2>Analisando o número $n ...</h2>";
        echo"<br/>Valores múltiplos: ";
        for ($i = 1; $i <= $n; $i++){
            if($n % $i == 0){
                echo "$i ";
                $c++;
            }
        }
        
        echo"<br/><br/>Total de múltiplos: $c";

        if($c == 1 || $c == 2){
            echo "<br/><br/>Resultado: $n <span style='color: red;'>É PRIMO!</span>";
        }else {
            echo "<br/><br/><span style='color: red; font-weight: bold;'>NÃO É PRIMO!</span>";
        }
    ?>
    
</body>
</html>