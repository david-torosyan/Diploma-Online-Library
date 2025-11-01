import Cookies from "js-cookie";
import { LoginResponseDto } from "../api/LibraryClient";

export function handleLoginResponse(response: LoginResponseDto): void {
  if (!response.user) {
    throw new Error("Invalid credentials or server error");
  }

  if (response.token) {
    Cookies.set("auth_token", response.token, {
      expires: 7,
      secure: true,
      sameSite: "Strict",
    });
    Cookies.set("user", JSON.stringify(response.user), {
      expires: 7,
      secure: true,
      sameSite: "Strict",
    });

    console.log("Login successful!");
    window.location.reload();
  } else {
    throw new Error("No token returned by server.");
  }
}
