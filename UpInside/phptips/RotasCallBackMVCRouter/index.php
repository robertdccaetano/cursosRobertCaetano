<?php

require __DIR__."/vendor/autoload.php";

use CoffeeCode\Router\Router;

$router = new Router(URL_BASE);

//Só os Controladores estão dentro da pasta App

/**
 * O Controller Web no método :home está no namespace Source\App
 */

$router->namespace("Source\App");

/**
 * WEB
 * home
 * Partindo da URL Raiz "/" acessa controlloer Web no método :home
 */
$router->group(null);
$router->get("/", "Web:home");
$router->get("/{filter}", "Web:home");



/**
 * blog
 */
$router->group("blog");
$router->get("/", "Web:blog");
$router->get("/{post_uri}", "Web:post");
$router->get("/categoria/{cat_uri}", "Web:category");

/**
 * contact
 * Regras dinâmicas a cima dentro da categoria e hierarquia e regras fixas
 * abaixo
 */
$router->group("contato");
$router->get("/", "Web:contact");
$router->post("/", "Web:contact");
$router->delete("/", "Web:contact");
$router->get("/{sector}", "Web:contact");

/**
 * ADMIN
 * home
 */
$router->group("admin");
$router->get("/", "Adm:home");


/**
 * ERRORS
 */
$router->group("ops");
$router->get("/{errcode}", "Web:error");

$router->dispatch();

if($router->error()) {
    $router->redirect("/ops/{$router->error()}");
}