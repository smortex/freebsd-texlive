# $FreeBSD$

PORTNAME=	antomega
PORTVERSION=	20140418
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Alternative language support for Omega/Lambda.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/plain/omega/omega.tex:${PORTSDIR}/print/texlive-omega

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
