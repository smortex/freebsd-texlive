# $FreeBSD$

PORTNAME=	make4ht
PORTVERSION=	20150704
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A build system for tex4ht.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
