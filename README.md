# 🎓 UNIPI GUIDE - University of Piraeus Interactive Guide 🏛️

**UNIPI GUIDE** is an interactive, user-friendly application designed to provide a detailed and engaging guide for both visitors and registered students of the **University of Piraeus**. 🌟 Whether you're a prospective student, a visitor, or a registered user, this app offers a rich and comprehensive overview of the university, its departments, and its events, all within a visually appealing and dynamic interface.

## 🚀 Key features:

1. 🔐 **User Access**:
    - Visitors can explore general information about the university.
    - **Registered students** enjoy additional features, including personalized content and enhanced navigation options.
    (Note: Registration is for students only)

2. 🏛️ University of Piraeus Focus:
    - A full overview of the university, including 2 departments (Informatics and Industrial Management & Technology), services, and events, brought to life with **text, images, and multimedia** (audio in Greek and animations).

3. 🔑 Login and Database Integration:
    - A simple, secure **login system** linked to a **SQLite database**, allowing students to access personalized features.

4. 💬 Comment Submission ("Reviews"):
    - Once logged in, users can leave comments or reviews about the university and its services in the **"Reviews"** section.
    - These comments are viewable by all users, fostering interaction and feedback within the community.

5. 📅 Calendar Features:
    - Users can view upcoming events and important dates in the "**Calendar**" section, accessible to both visitors and registered users.

6. 🖼️ Photo Slideshow:
    - A dynamic **photo slideshow** feature, implemented with a timer, enhances the visual experience by showcasing the university through beautiful imagery.

7. 📝 Export to Text File:
    - Users can export comments, notes, or information related to a specific subject or department to a .txt file for offline reference.

8. 🔄 Multiple Windows:
    - The app features multiple windows (forms), each hosting distinct sections of the university guide.

9. 📑 Menus for Easy Navigation:
    - Each form includes a **navigation menu** to guide users through different sections of the application.

10. 🔧 Input Validation:
    - Robust input validation checks ensure that incorrect data input does not cause crashes, improving the stability and reliability of the application.

--- 
## 🎬 Initial Form & User Flow

When the application is launched, the **initial form** offers a variety of options based on whether the user is a **visitor** or a **registered user**.

### 📍 Initial Screen (Before Login)

Upon starting the application, users are presented with the following options:
- **View Comments** 💬: Users can explore comments or reviews about the University of Piraeus.
- **Navigate** 🧭: Users can navigate to other sections of the guide, such as departments, events, and university information.
- **Login or Register** 🔑: Users can either log in if they are already registered or sign up to gain additional features.

Additionally, a **video** 📽️ about the University of Piraeus plays in the background, providing an informative and engaging introduction to the university for new visitors.

--- 
### 🔓 Post-Login Experience

Once a **registered user (student)** logs in, the interface adapts with additional functionality:
- **View Comments** 💬: The user can continue to view or leave comments in the "Reviews" section.
- **Navigate** 🧭: Users can navigate to other sections of the guide, such as departments, events, and university information.
- **Logout** 🔒: The user can log out of the application and return to visitor mode.
- **Synthesized Greeting**🎙️: Instead of the video, a welcoming image is displayed along with a speech synthesizer greeting the user with a personalized message like "Welcome to the University of Piraeus!"

This personalized experience enhances user interaction and immersion, making registered users feel more connected to the university's virtual environment.

---
### 🔄 Dynamic Content Swap

The switch between the **video** for visitors and the **image + speech synthesizer** for logged-in users is one of the standout features of the application, providing a more personalized and interactive experience for students.

This ensures that the application tailors content based on user roles, keeping it engaging for both **visitors** and **students**.
