# $FreeBSD$

PORTNAME=	datetime
PORTVERSION=	20150322
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Change format of \today with commands for current time.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/fmtcount/fmtcount.sty:${PORTSDIR}/print/texlive-fmtcount

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
