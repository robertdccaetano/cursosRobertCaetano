<?php

require __DIR__."/vendor/autoload.php";

use CoffeeCode\Router\Router;

$router = new Router(URL_BASE);

/**
 * $router->group("admin");
 * Tudo abaixo da linha de cima nas minhas rotas deve ser /admin/exemplo
 */
$router->group(null);
/**
 * $router->get();
 * Obtendo acesso através da URL
 * Quando encontrar a URL Raiz -> / 
 * executa a função que recebe o parâmetro $data
 */
$router->get("/", function ($data){
    echo "<h1>Olá, mundo! </h1>";
    var_dump($data);
});

$router->get("/contato", function ($data){
    echo "<h1>Contato</h1>";
    var_dump($data);
});


/**
 * $router->dispatch();
 * Faz a leitura de rotas e executa pela URL o comando desejável
 */

$router->group("ops");
$router->get("/{errcode}", function ($data) {
    echo "<h1>Erro {$data["errcode"]} </h1>";
    var_dump($data);
});

$router->dispatch();


if ($router->error()) {
    $router->redirect("/ops/{$router->error()}");
}