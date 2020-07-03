<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula11 Ex03</title>
</head>
<body>
    <?php
        $i =  isset($_GET["vi"])?$_GET["vi"]: 1;
        $f =  isset($_GET["vf"])?$_GET["vf"]: 10;
        $inc = isset($_GET["inc"])?$_GET["inc"]:1;

        if($i <= $f){
            while($i <= $f) {
                echo "$i ";
                $i += $inc; 
            }
        }elseif($i >= $f){
            while($i >= $f){
                echo "$i ";
                $i -= $inc;
            }
        }
    ?>
    
</body>
</html>