<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 11 - Exercício contador personalizado</title>
</head>
<body>
    <form action="aula11Ex03.php" method="get">
        Inicio: <input type="number" name="vi" min="0" max="100" /><br/><br/>
        Final: <input type="number" name="vf" min="0" max="100" /><br/><br/>
        <label for="incremento">Incremento:</label>
        <select name="inc" id="incremento">
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
        </select>
        <br/>
        <input type="submit" value="Contar" />
    </form>
    
</body>
</html>