$('#usersTable').on('click', '.clickableRow', function () {
    if ($(this).hasClass('success')) {
        $(this).removeClass('success');
    }
    else {
        $(this).addClass('success').siblings().removeClass('success');
    }
})