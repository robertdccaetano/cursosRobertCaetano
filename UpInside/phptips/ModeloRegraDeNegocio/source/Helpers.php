<?php

function ajaxResponse(string $param, array $values): string
{
    return json_encode([$param => $values]);
}
