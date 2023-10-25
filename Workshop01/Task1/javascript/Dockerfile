FROM node:21-alpine

WORKDIR /app

COPY main.js .
COPY package.json .
COPY package-lock.json .

COPY public public
COPY views views

RUN npm ci

ENV PORT=5000
ENV INSTANCE_NAME="Task1"
ENV INSTANCE_HASH=abcd

EXPOSE ${PORT}

ENTRYPOINT node main.js 


