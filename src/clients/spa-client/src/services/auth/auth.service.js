
const throwNotImplemented = () => {
    throw ("Not implemented");
}

export class AuthService {

    constructor() { }

    static get accessToken() {
        const token = localStorage["accessToken"]
        return token;
    }

    login(email, password) {
        throwNotImplemented();
    }

    logout() {
        throwNotImplemented();
    }
}