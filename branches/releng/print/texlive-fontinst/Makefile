# $FreeBSD$

PORTNAME=	fontinst
PORTVERSION=	20140429
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Help with installing fonts for TeX and LaTeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
