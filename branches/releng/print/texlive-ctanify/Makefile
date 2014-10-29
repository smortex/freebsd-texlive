# $FreeBSD$

PORTNAME=	ctanify
PORTVERSION=	20140418
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Prepare a package for upload to CTAN.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
