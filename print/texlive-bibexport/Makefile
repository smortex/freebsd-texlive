# $FreeBSD$

PORTNAME=	bibexport
PORTVERSION=	20150412
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Extract a BibTeX file based on a .aux file.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
