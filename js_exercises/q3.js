function checkEmailId(str) {
    str = str.toLowerCase();
    let atIndex = str.indexOf('@');
    let dotIndex = str.indexOf('.');

    if (atIndex > 0 && dotIndex > atIndex + 1) {
        return true;
    }

    return false;
}

console.log(checkEmailId("test@example.com"));