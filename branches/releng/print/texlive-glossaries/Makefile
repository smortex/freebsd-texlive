# $FreeBSD$

PORTNAME=	glossaries
PORTVERSION=	20141125
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Create glossaries and lists of acronyms.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
