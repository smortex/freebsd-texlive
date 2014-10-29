# $FreeBSD$

PORTNAME=	dviasm
PORTVERSION=	20140804
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A utility for editing DVI files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
