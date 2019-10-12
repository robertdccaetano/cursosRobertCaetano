<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula15 Ex 01</title>
</head>
<body>
 <?php
    function teste (&$x) {
        $x += 2;
        echo "O valor de X é $x";
    }
    
    $a = 3;
    teste($a);
    echo"<p>O valor de A é $a</p>";
 ?>
</body>
</html>