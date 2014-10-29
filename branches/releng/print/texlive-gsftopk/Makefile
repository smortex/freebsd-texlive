# $FreeBSD$

PORTNAME=	gsftopk
PORTVERSION=	20140429
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert "ghostscript fonts" to PK files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
