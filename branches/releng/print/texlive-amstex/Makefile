# New ports collection makefile for:	texlive-amstex
# Date created:		26/01/2009 16:10:24
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	amstex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	American Mathematical Society plain TeX macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.amstex.cnf:${PORTSDIR}/print/texlive-bin-amstex

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
