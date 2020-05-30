<?php $v->layout("_theme"); ?>

<div class="contact">
    <h2>Fale conosco!</h2>
    <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
    
    <form action="<?= url("contact"); ?>" method="POST" enctype="multipart/form-data">
        <input type="text" name="name" placeholder="Seu nome" />
        <input type="email" name="email" placeholder="Seu e-mail" />
        <textarea name="message" placeholder="Mensagem:" rows="3"></textarea>
        <button>Enviar mensagem!</button>
    </form>
</div>

<?= $v->start("scripts"); ?>
<script>
    $(function () {
       $("button").after('<button type="reset">Limpar</button>')
    });
</script>
<?= $v->end(); ?>