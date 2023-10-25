FROM golang:1.21-bookworm AS builder

WORKDIR /app

COPY go.mod .
COPY go.sum .
COPY main.go .

RUN CGO_ENABLED=true go build -o main ./...

FROM debian:bookworm

WORKDIR /app

COPY --from=builder /app/main .
COPY public public
COPY templates templates

ENV PORT=3000
ENV INSTANC_NAME="Go Dov Bear"
ENV INSTANCE_HASH= asdasd123

HEALTHCHECK --interval=30s --timeout=5s --retries=3 CMD "curl -s http://localhost:${PORT}/healthz || exit 1"



