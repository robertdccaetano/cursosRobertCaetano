<?php

require __DIR__."/../vendor/autoload.php";

use Source\Models\User;
use Source\Models\Address;



$user = new User();

$user->first_name = "Esdras";
$user->last_name = "Corse";
$user->email = "robert@meuamigojesus.com.br";
$user->passwd = password_hash("12345", PASSWORD_DEFAULT);
$user->genre = "M";
$user->save();

//$addr = new Address();
//$addr->add($user, "Rua Violeta de Mello Campos", "632");
//$addr->save();

echo "<pre>",
var_dump($user),
     "</pre>";


/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

