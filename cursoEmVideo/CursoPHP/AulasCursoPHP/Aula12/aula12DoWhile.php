<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 12 Repetição Do While</title>
</head>
<body>
    <?php
        $c = 0;
        do {
            echo "$c ";
            $c += 2;
        }while($c <= 20);

        echo"<br/>";
        
        $c = 10;
        do {
            echo "$c ";
            $c--;
        }while($c >= 1);

    ?>

</body>
</html>