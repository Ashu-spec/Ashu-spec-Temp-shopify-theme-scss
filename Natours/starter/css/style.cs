*,
*::after,
*::before {
  margin: 0;
  padding: 0;
  box-sizing: inherit; }

html {
  font-size: 62.5%; }

body {
  font-family: "Lato", sans-serif;
  font-weight: 400;
  font-size: 16-x;
  line-height: 1.7;
  color: #777;
  padding: 3rem;
  box-sizing: border-box; }

.header {
  height: 95vh;
  background-image: linear-gradient(to right bottom, rgba(126, 213, 111, 0.8), rgba(40, 180, 133, 0.8)), url(../img/hero.jpg);
  background-size: cover;
  background-position: top;
  position: relative;
  clip-path: polygon(0 0, 100% 0, 100% 75vh, 0 100%); }

.logo-box {
  position: absolute;
  top: 4rem;
  left: 4rem; }

.logo {
  height: 3.5rem;
  animation: moveInTop 2s; }

.text-box {
  position: absolute;
  top: 40%;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center; }

.heading-primary {
  color: #fff;
  text-transform: uppercase;
  backface-visibility: hidden;
  margin-bottom: 6rem; }

.heading-primary-main {
  display: block;
  font-size: 6rem;
  font-weight: 400;
  letter-spacing: 3.5rem;
  animation-name: moveInLeft;
  animation-duration: 1s; }

.heading-primary-sub {
  display: block;
  font-size: 2rem;
  font-weight: 700;
  letter-spacing: 1.75rem;
  animation-name: moveInRight;
  animation-duration: 1s; }

@keyframes moveInLeft {
  0% {
    opacity: 0;
    transform: translateX(-10rem); }
  80% {
    opacity: 0.8;
    transform: translateX(10rem); }
  100% {
    opacity: 1;
    transform: translate(0); } }

@keyframes moveInRight {
  0% {
    opacity: 0;
    transform: translateX(30rem); }
  80% {
    opacity: 0.8;
    transform: translateX(-10rem); }
  100% {
    opacity: 1;
    transform: translate(0); } }

@keyframes moveInTop {
  0% {
    opacity: 0;
    transform: translateY(-4rem); }
  80% {
    opacity: 0.8;
    transform: translateY(0.5rem); }
  100% {
    opacity: 1;
    transform: translate(0); } }

@keyframes moveInBottom {
  0% {
    opacity: 0;
    transform: translateY(3rem); }
  100% {
    opacity: 1;
    transform: translate(0); } }

.btn:link,
.btn:visited {
  text-transform: uppercase;
  text-decoration: none;
  padding: 1.5rem 4rem;
  display: inline-block;
  border-radius: 10rem;
  transition: all .2s;
  position: relative;
  font-size: 1.6rem; }

.btn:hover {
  transform: translateY(-1rem);
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.2); }

.btn:active {
  transform: translateY(-0.1rem);
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.2); }

.btn-white {
  background-color: #fff;
  color: #777; }

.btn::after {
  content: "";
  display: inline-block;
  height: 100%;
  width: 100%;
  border-radius: 100px;
  position: absolute;
  top: 0;
  left: 0;
  z-index: -1;
  transition: all .4s; }

.btn-white::after {
  background-color: #fff; }

.btn:hover::after {
  transform: scaleX(1.4) scaleY(1.6);
  opacity: 0; }

.btn-animated {
  animation: moveInBottom .5s ease-out .75s;
  animation-fill-mode: backwards; }
